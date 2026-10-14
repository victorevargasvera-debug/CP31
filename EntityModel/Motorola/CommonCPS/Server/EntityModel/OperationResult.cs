using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.Common.CustomException;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200000E RID: 14
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class OperationResult
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000048E4 File Offset: 0x00002AE4
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00004990 File Offset: 0x00002B90
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid Uuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1461055456;
				short num2 = num;
				num = (short)226881504;
				switch (num2 == num)
				{
				}
				num = (short)1313538048;
				if (num != 0)
				{
				}
				num = (short)1227751424;
				short num3 = num;
				num = (short)1408827393;
				if (num != 0)
				{
				}
				return this.<Uuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)822813989;
				short num2 = num;
				num = (short)2039751973;
				switch (num2 == num)
				{
				}
				num = (short)981991425;
				if (num != 0)
				{
				}
				num = (short)316342272;
				short num3 = num;
				num = (short)2000683008;
				if (num != 0)
				{
				}
				this.<Uuid>k__BackingField = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00004A40 File Offset: 0x00002C40
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00004AF0 File Offset: 0x00002CF0
		[global::System.Runtime.Serialization.DataMember]
		public int Status
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1135280129;
				if (num != 0)
				{
				}
				num = (short)1769671772;
				short num2 = num;
				num = (short)1910443100;
				switch (num2 == num)
				{
				}
				num = (short)546504704;
				short num3 = num;
				num = (short)942997504;
				if (num != 0)
				{
				}
				return this.<Status>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1040862816;
				short num2 = num;
				num = (short)238440032;
				switch (num2 == num)
				{
				}
				num = (short)1979252737;
				if (num != 0)
				{
				}
				num = (short)835190784;
				short num3 = num;
				num = (short)569769984;
				if (num != 0)
				{
				}
				this.<Status>k__BackingField = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00004B9C File Offset: 0x00002D9C
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00004C48 File Offset: 0x00002E48
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.CustomException.CommonErrorCode ErrorCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1483475966;
				short num2 = num;
				num = (short)332991486;
				switch (num2 == num)
				{
				}
				num = (short)355860481;
				if (num != 0)
				{
				}
				num = (short)765591552;
				short num3 = num;
				num = (short)164823040;
				if (num != 0)
				{
				}
				return this.<ErrorCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1746076389;
				short num2 = num;
				num = (short)872743653;
				switch (num2 == num)
				{
				}
				num = (short)1796669440;
				if (num != 0)
				{
				}
				num = (short)1061683200;
				short num3 = num;
				num = (short)273743873;
				if (num != 0)
				{
				}
				this.<ErrorCode>k__BackingField = value;
			}
		}
	}
}
