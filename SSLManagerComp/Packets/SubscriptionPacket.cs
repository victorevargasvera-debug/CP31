using System;

namespace SSLMangrComp.Packets
{
	// Token: 0x0200002C RID: 44
	public abstract class SubscriptionPacket : global::SSLMangrComp.Packets.PacketBase
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00010CDC File Offset: 0x0000EEDC
		public string EntityValue
		{
			get
			{
				short num = (short)740759072;
				short num2 = num;
				num = (short)1744377376;
				switch (num2 == num)
				{
				}
				num = (short)1784610816;
				if (num != 0)
				{
				}
				num = (short)2015232001;
				if (num != 0)
				{
				}
				num = (short)168165376;
				short num3 = num;
				return this.EntitiesValue;
			}
		}

		// Token: 0x06000114 RID: 276
		public abstract global::SSLMangrComp.Packets.SubscriptionPacket CreateRefreshSubscription(int newExpiry);

		// Token: 0x06000115 RID: 277
		public abstract global::SSLMangrComp.Packets.SubscriptionPacket CreateCancelSubscription();

		// Token: 0x0400009C RID: 156
		protected global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType PacketSubscriptionType;

		// Token: 0x0400009D RID: 157
		protected int Expiry = -1;

		// Token: 0x0400009E RID: 158
		protected global::SSLMangrComp.Packets.EntitiesTypes EntitiesType;

		// Token: 0x0400009F RID: 159
		protected string EntitiesValue;

		// Token: 0x040000A0 RID: 160
		protected string EventsValue;

		// Token: 0x0200002D RID: 45
		protected enum SubscribtionType
		{
			// Token: 0x040000A2 RID: 162
			Subscription,
			// Token: 0x040000A3 RID: 163
			RefreshSubscription,
			// Token: 0x040000A4 RID: 164
			CancelSubscription,
			// Token: 0x040000A5 RID: 165
			OneTimeSubscription
		}
	}
}
