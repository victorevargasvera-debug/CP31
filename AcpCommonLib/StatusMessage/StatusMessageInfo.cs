using System;
using System.Runtime.CompilerServices;
using AcpCommonLib.Exceptions;
using AcpCommonResources;

namespace AcpCommonLib.StatusMessage
{
	// Token: 0x02000037 RID: 55
	public class StatusMessageInfo
	{
		// Token: 0x06000232 RID: 562 RVA: 0x00015514 File Offset: 0x00013714
		internal StatusMessageInfo(global::AcpCommonLib.StatusMsgType A_0, string A_1)
		{
			int a_ = 2;
			base..ctor();
			this.MessageType = A_0;
			this.Message = A_1;
			switch (A_0)
			{
			case global::AcpCommonLib.StatusMsgType.Error:
				this.Type = global::AcpCommonResources.AcpResources.Error_Id;
				this.ImageLink = global::AcpCommonLib.Exceptions.AcpSecurityException.b("\udaf3\ud8f5ퟷ퓹틻퇽槿愁欃栅笇┉椋簍戏紑易㠕焗礙猛", a_);
				return;
			case global::AcpCommonLib.StatusMsgType.Warning:
				this.Type = global::AcpCommonResources.AcpResources.Warning_Id;
				this.ImageLink = global::AcpCommonLib.Exceptions.AcpSecurityException.b("\udaf3\ud8f5ퟷ퓹틻퇽槿愁欃栅笇┉笋漍戏簑紓砕缗㐙甛紝伟", a_);
				return;
			case global::AcpCommonLib.StatusMsgType.Info:
				this.Type = global::AcpCommonResources.AcpResources.Info_Id;
				this.ImageLink = global::AcpCommonLib.Exceptions.AcpSecurityException.b("\udaf3\ud8f5ퟷ퓹틻퇽槿愁欃栅笇┉䔋䀍嘏崑㨓引嬗唙", a_);
				return;
			default:
				return;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000233 RID: 563 RVA: 0x000155B4 File Offset: 0x000137B4
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00015660 File Offset: 0x00013860
		internal global::AcpCommonLib.StatusMsgType MessageType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1134415736;
				short num2 = num;
				num = (short)2108673912;
				switch (num2 == num)
				{
				}
				num = (short)31129600;
				if (num != 0)
				{
				}
				num = (short)256901121;
				if (num != 0)
				{
				}
				num = (short)1775960064;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1326205923;
				short num2 = num;
				num = (short)121588707;
				switch (num2 == num)
				{
				}
				num = (short)1694826497;
				if (num != 0)
				{
				}
				num = (short)310312960;
				if (num != 0)
				{
				}
				num = (short)1849688064;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00015714 File Offset: 0x00013914
		// (set) Token: 0x06000236 RID: 566 RVA: 0x000157C4 File Offset: 0x000139C4
		public string Type
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1859848550;
				short num2 = num;
				num = (short)408488294;
				switch (num2 == num)
				{
				}
				num = (short)1692270592;
				if (num != 0)
				{
				}
				num = (short)1157365761;
				if (num != 0)
				{
				}
				num = (short)53936128;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1179960075;
				short num2 = num;
				num = (short)638042891;
				switch (num2 == num)
				{
				}
				num = (short)1259077633;
				if (num != 0)
				{
				}
				num = (short)440532992;
				if (num != 0)
				{
				}
				num = (short)1387528192;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00015874 File Offset: 0x00013A74
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00015928 File Offset: 0x00013B28
		public string Message
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1348796416;
				short num2 = num;
				num = (short)500957185;
				if (num != 0)
				{
				}
				num = (short)243642243;
				short num3 = num;
				num = (short)526036867;
				switch (num3 == num)
				{
				}
				num = (short)2030239744;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2054291456;
				short num2 = num;
				num = (short)1203772535;
				short num3 = num;
				num = (short)2088115319;
				switch (num3 == num)
				{
				}
				num = (short)1287716865;
				if (num != 0)
				{
				}
				num = (short)1620967424;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000239 RID: 569 RVA: 0x000159D8 File Offset: 0x00013BD8
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00015A88 File Offset: 0x00013C88
		public string ImageLink
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1159790592;
				short num2 = num;
				num = (short)752876516;
				short num3 = num;
				num = (short)1035664356;
				switch (num3 == num)
				{
				}
				num = (short)951582721;
				if (num != 0)
				{
				}
				num = (short)1974009856;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1001652224;
				short num2 = num;
				num = (short)788531920;
				short num3 = num;
				num = (short)1729825488;
				switch (num3 == num)
				{
				}
				num = (short)856293377;
				if (num != 0)
				{
				}
				num = (short)511836160;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x040000B3 RID: 179
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.StatusMsgType a;

		// Token: 0x040000B4 RID: 180
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x040000B5 RID: 181
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x040000B6 RID: 182
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;
	}
}
