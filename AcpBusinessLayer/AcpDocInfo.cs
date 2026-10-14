using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;

namespace AcpBusinessLayer
{
	// Token: 0x02000008 RID: 8
	[global::System.Serializable]
	public class AcpDocInfo : global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000078A4 File Offset: 0x00005AA4
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00007950 File Offset: 0x00005B50
		internal global::AcpBusinessLayer.AcpDocument Document
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1452060239;
				short num2 = num;
				num = (short)1343336015;
				switch (num2 == num)
				{
				}
				num = (short)1901330433;
				if (num != 0)
				{
				}
				num = (short)1052770304;
				if (num != 0)
				{
				}
				num = (short)1567358976;
				short num3 = num;
				return this.<Document>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)701089107;
				short num2 = num;
				num = (short)1285014867;
				switch (num2 == num)
				{
				}
				num = (short)88276992;
				if (num != 0)
				{
				}
				num = (short)1291780097;
				if (num != 0)
				{
				}
				num = (short)855703552;
				short num3 = num;
				this.<Document>k__BackingField = value;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00007A00 File Offset: 0x00005C00
		public AcpDocInfo(global::AcpBusinessLayer.AcpDocument document)
		{
			this.Document = document;
			this.HasInvalids = global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.HasFields;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00007A2C File Offset: 0x00005C2C
		public AcpDocInfo(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 8;
			base..ctor();
			this.HasInvalids = info.GetBoolean(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鋙뷛귝꧟賡鋣蟥蓧菩裫鷭", a_));
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00007A64 File Offset: 0x00005C64
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00007B14 File Offset: 0x00005D14
		public bool HasInvalids
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1498364867;
				short num2 = num;
				num = (short)1629699011;
				switch (num2 == num)
				{
				}
				num = (short)1978204161;
				if (num != 0)
				{
				}
				num = (short)467075072;
				if (num != 0)
				{
				}
				num = (short)1636433920;
				short num3 = num;
				return this.<HasInvalids>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1136236946;
				short num2 = num;
				num = (short)1476499858;
				switch (num2 == num)
				{
				}
				num = (short)218431489;
				if (num != 0)
				{
				}
				num = (short)2099970048;
				if (num != 0)
				{
				}
				num = (short)963248128;
				short num3 = num;
				this.<HasInvalids>k__BackingField = value;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00007BC8 File Offset: 0x00005DC8
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 2;
			short num = (short)1446176925;
			short num2 = num;
			num = (short)1473767581;
			switch (num2 == num)
			{
			}
			num = (short)1134034945;
			if (num != 0)
			{
			}
			num = (short)1960378368;
			if (num != 0)
			{
			}
			num = (short)649068544;
			short num3 = num;
			info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鳓럕ꯗ鏙닛꣝臟軡跣若鯧", a_), this.HasInvalids);
		}
	}
}
