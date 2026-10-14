using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000364 RID: 868
	public enum GenericIssueErrorType
	{
		// Token: 0x04000DD0 RID: 3536
		[global::System.Runtime.Serialization.EnumMember(Value = "CrossOriginPortalPostMessageError")]
		CrossOriginPortalPostMessageError,
		// Token: 0x04000DD1 RID: 3537
		[global::System.Runtime.Serialization.EnumMember(Value = "FormLabelForNameError")]
		FormLabelForNameError,
		// Token: 0x04000DD2 RID: 3538
		[global::System.Runtime.Serialization.EnumMember(Value = "FormDuplicateIdForInputError")]
		FormDuplicateIdForInputError,
		// Token: 0x04000DD3 RID: 3539
		[global::System.Runtime.Serialization.EnumMember(Value = "FormInputWithNoLabelError")]
		FormInputWithNoLabelError,
		// Token: 0x04000DD4 RID: 3540
		[global::System.Runtime.Serialization.EnumMember(Value = "FormAutocompleteAttributeEmptyError")]
		FormAutocompleteAttributeEmptyError,
		// Token: 0x04000DD5 RID: 3541
		[global::System.Runtime.Serialization.EnumMember(Value = "FormEmptyIdAndNameAttributesForInputError")]
		FormEmptyIdAndNameAttributesForInputError,
		// Token: 0x04000DD6 RID: 3542
		[global::System.Runtime.Serialization.EnumMember(Value = "FormAriaLabelledByToNonExistingId")]
		FormAriaLabelledByToNonExistingId,
		// Token: 0x04000DD7 RID: 3543
		[global::System.Runtime.Serialization.EnumMember(Value = "FormInputAssignedAutocompleteValueToIdOrNameAttributeError")]
		FormInputAssignedAutocompleteValueToIdOrNameAttributeError,
		// Token: 0x04000DD8 RID: 3544
		[global::System.Runtime.Serialization.EnumMember(Value = "FormLabelHasNeitherForNorNestedInput")]
		FormLabelHasNeitherForNorNestedInput,
		// Token: 0x04000DD9 RID: 3545
		[global::System.Runtime.Serialization.EnumMember(Value = "FormLabelForMatchesNonExistingIdError")]
		FormLabelForMatchesNonExistingIdError,
		// Token: 0x04000DDA RID: 3546
		[global::System.Runtime.Serialization.EnumMember(Value = "FormInputHasWrongButWellIntendedAutocompleteValueError")]
		FormInputHasWrongButWellIntendedAutocompleteValueError
	}
}
