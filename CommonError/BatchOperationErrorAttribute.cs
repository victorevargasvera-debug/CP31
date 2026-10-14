using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.CustomException
{
	// Token: 0x02000006 RID: 6
	[global::System.Serializable]
	public sealed class BatchOperationErrorAttribute : global::System.Attribute
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002CE8 File Offset: 0x00000EE8
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002D98 File Offset: 0x00000F98
		[global::System.Runtime.Serialization.DataMember]
		public bool IsFatal
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)210841501;
				short num2 = num;
				num = (short)460468125;
				switch (num2 == num)
				{
				}
				num = (short)347209729;
				if (num != 0)
				{
				}
				num = (short)2001010688;
				if (num != 0)
				{
				}
				num = (short)1225719808;
				short num3 = num;
				return this.<IsFatal>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1337883130;
				short num2 = num;
				num = (short)464353786;
				switch (num2 == num)
				{
				}
				num = (short)952500224;
				if (num != 0)
				{
				}
				num = (short)1393491969;
				if (num != 0)
				{
				}
				num = (short)54263808;
				short num3 = num;
				this.<IsFatal>k__BackingField = value;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002E4C File Offset: 0x0000104C
		public BatchOperationErrorAttribute(bool isFatal = false)
		{
			this.IsFatal = isFatal;
		}
	}
}
