using System;
using System.Xml.Serialization;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200001F RID: 31
	public enum InvalidValueBehavior
	{
		// Token: 0x04000072 RID: 114
		[global::System.Xml.Serialization.XmlEnum("Standard")]
		Default,
		// Token: 0x04000073 RID: 115
		RetainValue,
		// Token: 0x04000074 RID: 116
		RevertValue,
		// Token: 0x04000075 RID: 117
		DisplayErrorMessage
	}
}
