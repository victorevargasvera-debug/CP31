using System;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000547 RID: 1351
	internal enum MappingErrorCode
	{
		// Token: 0x040016FC RID: 5884
		Value = 2000,
		// Token: 0x040016FD RID: 5885
		InvalidContent,
		// Token: 0x040016FE RID: 5886
		InvalidEntityContainer,
		// Token: 0x040016FF RID: 5887
		InvalidEntitySet,
		// Token: 0x04001700 RID: 5888
		InvalidEntityType,
		// Token: 0x04001701 RID: 5889
		InvalidAssociationSet,
		// Token: 0x04001702 RID: 5890
		InvalidAssociationType,
		// Token: 0x04001703 RID: 5891
		InvalidTable,
		// Token: 0x04001704 RID: 5892
		InvalidComplexType,
		// Token: 0x04001705 RID: 5893
		InvalidEdmMember,
		// Token: 0x04001706 RID: 5894
		InvalidStorageMember,
		// Token: 0x04001707 RID: 5895
		TableMappingFragmentExpected,
		// Token: 0x04001708 RID: 5896
		SetMappingExpected,
		// Token: 0x04001709 RID: 5897
		DuplicateSetMapping = 2014,
		// Token: 0x0400170A RID: 5898
		DuplicateTypeMapping,
		// Token: 0x0400170B RID: 5899
		ConditionError,
		// Token: 0x0400170C RID: 5900
		RootMappingElementMissing = 2018,
		// Token: 0x0400170D RID: 5901
		IncompatibleMemberMapping,
		// Token: 0x0400170E RID: 5902
		InvalidEnumValue = 2023,
		// Token: 0x0400170F RID: 5903
		XmlSchemaParsingError,
		// Token: 0x04001710 RID: 5904
		XmlSchemaValidationError,
		// Token: 0x04001711 RID: 5905
		AmbiguousModificationFunctionMappingForAssociationSet,
		// Token: 0x04001712 RID: 5906
		MissingSetClosureInModificationFunctionMapping,
		// Token: 0x04001713 RID: 5907
		MissingModificationFunctionMappingForEntityType,
		// Token: 0x04001714 RID: 5908
		InvalidTableNameAttributeWithModificationFunctionMapping,
		// Token: 0x04001715 RID: 5909
		InvalidModificationFunctionMappingForMultipleTypes,
		// Token: 0x04001716 RID: 5910
		AmbiguousResultBindingInModificationFunctionMapping,
		// Token: 0x04001717 RID: 5911
		InvalidAssociationSetRoleInModificationFunctionMapping,
		// Token: 0x04001718 RID: 5912
		InvalidAssociationSetCardinalityInModificationFunctionMapping,
		// Token: 0x04001719 RID: 5913
		RedundantEntityTypeMappingInModificationFunctionMapping,
		// Token: 0x0400171A RID: 5914
		MissingVersionInModificationFunctionMapping,
		// Token: 0x0400171B RID: 5915
		InvalidVersionInModificationFunctionMapping,
		// Token: 0x0400171C RID: 5916
		InvalidParameterInModificationFunctionMapping,
		// Token: 0x0400171D RID: 5917
		ParameterBoundTwiceInModificationFunctionMapping,
		// Token: 0x0400171E RID: 5918
		CSpaceMemberMappedToMultipleSSpaceMemberWithDifferentTypes,
		// Token: 0x0400171F RID: 5919
		NoEquivalentStorePrimitiveTypeFound,
		// Token: 0x04001720 RID: 5920
		NoEquivalentStorePrimitiveTypeWithFacetsFound,
		// Token: 0x04001721 RID: 5921
		InvalidModificationFunctionMappingPropertyParameterTypeMismatch,
		// Token: 0x04001722 RID: 5922
		InvalidModificationFunctionMappingMultipleEndsOfAssociationMapped,
		// Token: 0x04001723 RID: 5923
		InvalidModificationFunctionMappingUnknownFunction,
		// Token: 0x04001724 RID: 5924
		InvalidModificationFunctionMappingAmbiguousFunction,
		// Token: 0x04001725 RID: 5925
		InvalidModificationFunctionMappingNotValidFunction,
		// Token: 0x04001726 RID: 5926
		InvalidModificationFunctionMappingNotValidFunctionParameter,
		// Token: 0x04001727 RID: 5927
		InvalidModificationFunctionMappingAssociationSetNotMappedForOperation,
		// Token: 0x04001728 RID: 5928
		InvalidModificationFunctionMappingAssociationEndMappingInvalidForEntityType,
		// Token: 0x04001729 RID: 5929
		MappingFunctionImportStoreFunctionDoesNotExist,
		// Token: 0x0400172A RID: 5930
		MappingFunctionImportStoreFunctionAmbiguous,
		// Token: 0x0400172B RID: 5931
		MappingFunctionImportFunctionImportDoesNotExist,
		// Token: 0x0400172C RID: 5932
		MappingFunctionImportFunctionImportMappedMultipleTimes,
		// Token: 0x0400172D RID: 5933
		MappingFunctionImportTargetFunctionMustBeNonComposable,
		// Token: 0x0400172E RID: 5934
		MappingFunctionImportTargetParameterHasNoCorrespondingImportParameter,
		// Token: 0x0400172F RID: 5935
		MappingFunctionImportImportParameterHasNoCorrespondingTargetParameter,
		// Token: 0x04001730 RID: 5936
		MappingFunctionImportIncompatibleParameterMode,
		// Token: 0x04001731 RID: 5937
		MappingFunctionImportIncompatibleParameterType,
		// Token: 0x04001732 RID: 5938
		MappingFunctionImportRowsAffectedParameterDoesNotExist,
		// Token: 0x04001733 RID: 5939
		MappingFunctionImportRowsAffectedParameterHasWrongType,
		// Token: 0x04001734 RID: 5940
		MappingFunctionImportRowsAffectedParameterHasWrongMode,
		// Token: 0x04001735 RID: 5941
		EmptyContainerMapping,
		// Token: 0x04001736 RID: 5942
		EmptySetMapping,
		// Token: 0x04001737 RID: 5943
		TableNameAttributeWithQueryView,
		// Token: 0x04001738 RID: 5944
		EmptyQueryView,
		// Token: 0x04001739 RID: 5945
		PropertyMapsWithQueryView,
		// Token: 0x0400173A RID: 5946
		MissingSetClosureInQueryViews,
		// Token: 0x0400173B RID: 5947
		InvalidQueryView,
		// Token: 0x0400173C RID: 5948
		InvalidQueryViewResultType,
		// Token: 0x0400173D RID: 5949
		ItemWithSameNameExistsBothInCSpaceAndSSpace,
		// Token: 0x0400173E RID: 5950
		MappingUnsupportedExpressionKindQueryView,
		// Token: 0x0400173F RID: 5951
		MappingUnsupportedScanTargetQueryView,
		// Token: 0x04001740 RID: 5952
		MappingUnsupportedPropertyKindQueryView,
		// Token: 0x04001741 RID: 5953
		MappingUnsupportedInitializationQueryView,
		// Token: 0x04001742 RID: 5954
		MappingFunctionImportEntityTypeMappingForFunctionNotReturningEntitySet,
		// Token: 0x04001743 RID: 5955
		MappingFunctionImportAmbiguousTypeConditions,
		// Token: 0x04001744 RID: 5956
		MappingOfAbstractType = 2078,
		// Token: 0x04001745 RID: 5957
		StorageEntityContainerNameMismatchWhileSpecifyingPartialMapping,
		// Token: 0x04001746 RID: 5958
		TypeNameForFirstQueryView,
		// Token: 0x04001747 RID: 5959
		NoTypeNameForTypeSpecificQueryView,
		// Token: 0x04001748 RID: 5960
		QueryViewExistsForEntitySetAndType,
		// Token: 0x04001749 RID: 5961
		TypeNameContainsMultipleTypesForQueryView,
		// Token: 0x0400174A RID: 5962
		IsTypeOfQueryViewForBaseType,
		// Token: 0x0400174B RID: 5963
		InvalidTypeInScalarProperty,
		// Token: 0x0400174C RID: 5964
		AlreadyMappedStorageEntityContainer,
		// Token: 0x0400174D RID: 5965
		UnsupportedQueryViewInEntityContainerMapping,
		// Token: 0x0400174E RID: 5966
		MappingAllQueryViewAtCompileTime,
		// Token: 0x0400174F RID: 5967
		MappingNoViewsCanBeGenerated,
		// Token: 0x04001750 RID: 5968
		MappingStoreProviderReturnsNullEdmType,
		// Token: 0x04001751 RID: 5969
		DuplicateMemberMapping = 2092,
		// Token: 0x04001752 RID: 5970
		MappingFunctionImportUnexpectedEntityTypeMapping,
		// Token: 0x04001753 RID: 5971
		MappingFunctionImportUnexpectedComplexTypeMapping,
		// Token: 0x04001754 RID: 5972
		DistinctFragmentInReadWriteContainer = 2096,
		// Token: 0x04001755 RID: 5973
		EntitySetMismatchOnAssociationSetEnd,
		// Token: 0x04001756 RID: 5974
		InvalidModificationFunctionMappingAssociationEndForeignKey,
		// Token: 0x04001757 RID: 5975
		CannotLoadDifferentVersionOfSchemaInTheSameItemCollection = 2100,
		// Token: 0x04001758 RID: 5976
		MappingDifferentMappingEdmStoreVersion,
		// Token: 0x04001759 RID: 5977
		MappingDifferentEdmStoreVersion,
		// Token: 0x0400175A RID: 5978
		UnmappedFunctionImport,
		// Token: 0x0400175B RID: 5979
		MappingFunctionImportReturnTypePropertyNotMapped,
		// Token: 0x0400175C RID: 5980
		InvalidType = 2106,
		// Token: 0x0400175D RID: 5981
		MappingFunctionImportTVFExpected = 2108,
		// Token: 0x0400175E RID: 5982
		MappingFunctionImportScalarMappingTypeMismatch,
		// Token: 0x0400175F RID: 5983
		MappingFunctionImportScalarMappingToMulticolumnTVF,
		// Token: 0x04001760 RID: 5984
		MappingFunctionImportTargetFunctionMustBeComposable,
		// Token: 0x04001761 RID: 5985
		UnsupportedFunctionCallInQueryView,
		// Token: 0x04001762 RID: 5986
		FunctionResultMappingCountMismatch,
		// Token: 0x04001763 RID: 5987
		MappingFunctionImportCannotInferTargetFunctionKeys
	}
}
