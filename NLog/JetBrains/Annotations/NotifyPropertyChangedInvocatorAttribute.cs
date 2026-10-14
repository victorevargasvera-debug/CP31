using System;

namespace JetBrains.Annotations
{
	// Token: 0x02000195 RID: 405
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	internal sealed class NotifyPropertyChangedInvocatorAttribute : global::System.Attribute
	{
		// Token: 0x06001153 RID: 4435 RVA: 0x0002DEC8 File Offset: 0x0002C0C8
		public NotifyPropertyChangedInvocatorAttribute()
		{
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x0002DED0 File Offset: 0x0002C0D0
		public NotifyPropertyChangedInvocatorAttribute(string parameterName)
		{
			this.ParameterName = parameterName;
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x0002DEDF File Offset: 0x0002C0DF
		// (set) Token: 0x06001156 RID: 4438 RVA: 0x0002DEE7 File Offset: 0x0002C0E7
		public string ParameterName { get; private set; }
	}
}
