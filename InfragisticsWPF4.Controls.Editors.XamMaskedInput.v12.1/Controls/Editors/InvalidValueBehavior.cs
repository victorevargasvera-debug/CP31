using System;
using System.Xml.Serialization;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200001F RID: 31
	public enum InvalidValueBehavior
	{
		// Token: 0x0400006C RID: 108
		[global::System.Xml.Serialization.XmlEnum("Standard")]
		Default,
		// Token: 0x0400006D RID: 109
		RetainValue,
		// Token: 0x0400006E RID: 110
		RevertValue,
		// Token: 0x0400006F RID: 111
		DisplayErrorMessage
	}
}
