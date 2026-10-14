using System;
using System.Collections;
using System.Globalization;

namespace System.Windows.Interactivity
{
	// Token: 0x02000009 RID: 9
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Property, AllowMultiple = true)]
	[global::System.CLSCompliant(false)]
	public sealed class DefaultTriggerAttribute : global::System.Attribute
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000277D File Offset: 0x0000097D
		public global::System.Type TargetType
		{
			get
			{
				return this.targetType;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002785 File Offset: 0x00000985
		public global::System.Type TriggerType
		{
			get
			{
				return this.triggerType;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000029 RID: 41 RVA: 0x0000278D File Offset: 0x0000098D
		public global::System.Collections.IEnumerable Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002798 File Offset: 0x00000998
		public DefaultTriggerAttribute(global::System.Type targetType, global::System.Type triggerType, object parameter) : this(targetType, triggerType, new object[]
		{
			parameter
		})
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000027BC File Offset: 0x000009BC
		public DefaultTriggerAttribute(global::System.Type targetType, global::System.Type triggerType, params object[] parameters)
		{
			if (!typeof(global::System.Windows.Interactivity.TriggerBase).IsAssignableFrom(triggerType))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.DefaultTriggerAttributeInvalidTriggerTypeSpecifiedExceptionMessage, new object[]
				{
					triggerType.Name
				}));
			}
			this.targetType = targetType;
			this.triggerType = triggerType;
			this.parameters = parameters;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000281C File Offset: 0x00000A1C
		public global::System.Windows.Interactivity.TriggerBase Instantiate()
		{
			object obj = null;
			try
			{
				obj = global::System.Activator.CreateInstance(this.TriggerType, this.parameters);
			}
			catch
			{
			}
			return (global::System.Windows.Interactivity.TriggerBase)obj;
		}

		// Token: 0x0400000D RID: 13
		private global::System.Type targetType;

		// Token: 0x0400000E RID: 14
		private global::System.Type triggerType;

		// Token: 0x0400000F RID: 15
		private object[] parameters;
	}
}
