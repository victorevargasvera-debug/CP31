using System;
using System.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000D9 RID: 217
	public sealed class NewSessionTicket
	{
		// Token: 0x060007C9 RID: 1993 RVA: 0x00020E15 File Offset: 0x0001F015
		public NewSessionTicket(long ticketLifetimeHint, byte[] ticket)
		{
			this.m_ticketLifetimeHint = ticketLifetimeHint;
			this.m_ticket = ticket;
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00020E2B File Offset: 0x0001F02B
		public long TicketLifetimeHint
		{
			get
			{
				return this.m_ticketLifetimeHint;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x00020E33 File Offset: 0x0001F033
		public byte[] Ticket
		{
			get
			{
				return this.m_ticket;
			}
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00020E3B File Offset: 0x0001F03B
		public void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint32(this.TicketLifetimeHint, output);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(this.Ticket, output);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00020E58 File Offset: 0x0001F058
		public static global::Org.BouncyCastle.Tls.NewSessionTicket Parse(global::System.IO.Stream input)
		{
			long ticketLifetimeHint = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint32(input);
			byte[] ticket = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input);
			return new global::Org.BouncyCastle.Tls.NewSessionTicket(ticketLifetimeHint, ticket);
		}

		// Token: 0x040005F6 RID: 1526
		private readonly long m_ticketLifetimeHint;

		// Token: 0x040005F7 RID: 1527
		private readonly byte[] m_ticket;
	}
}
