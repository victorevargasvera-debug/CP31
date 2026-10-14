using System;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200033D RID: 829
	public class NewSessionTicket
	{
		// Token: 0x0600223E RID: 8766 RVA: 0x00097846 File Offset: 0x00095A46
		public NewSessionTicket(long ticketLifetimeHint, byte[] ticket)
		{
			this.mTicketLifetimeHint = ticketLifetimeHint;
			this.mTicket = ticket;
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x0600223F RID: 8767 RVA: 0x0009785C File Offset: 0x00095A5C
		public virtual long TicketLifetimeHint
		{
			get
			{
				return this.mTicketLifetimeHint;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x00097864 File Offset: 0x00095A64
		public virtual byte[] Ticket
		{
			get
			{
				return this.mTicket;
			}
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x0009786C File Offset: 0x00095A6C
		public virtual void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint32(this.mTicketLifetimeHint, output);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(this.mTicket, output);
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00097888 File Offset: 0x00095A88
		public static global::Org.BouncyCastle.Crypto.Tls.NewSessionTicket Parse(global::System.IO.Stream input)
		{
			long ticketLifetimeHint = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint32(input);
			byte[] ticket = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input);
			return new global::Org.BouncyCastle.Crypto.Tls.NewSessionTicket(ticketLifetimeHint, ticket);
		}

		// Token: 0x04000DC4 RID: 3524
		protected readonly long mTicketLifetimeHint;

		// Token: 0x04000DC5 RID: 3525
		protected readonly byte[] mTicket;
	}
}
