using System;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200056F RID: 1391
	public class Crc24
	{
		// Token: 0x06003524 RID: 13604 RVA: 0x000FDA44 File Offset: 0x000FBC44
		public void Update(int b)
		{
			this.crc ^= b << 16;
			for (int i = 0; i < 8; i++)
			{
				this.crc <<= 1;
				if ((this.crc & 16777216) != 0)
				{
					this.crc ^= 25578747;
				}
			}
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x000FDA9C File Offset: 0x000FBC9C
		[global::System.Obsolete("Use 'Value' property instead")]
		public int GetValue()
		{
			return this.crc;
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06003526 RID: 13606 RVA: 0x000FDAA4 File Offset: 0x000FBCA4
		public int Value
		{
			get
			{
				return this.crc;
			}
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x000FDAAC File Offset: 0x000FBCAC
		public void Reset()
		{
			this.crc = 11994318;
		}

		// Token: 0x040017CB RID: 6091
		private const int Crc24Init = 11994318;

		// Token: 0x040017CC RID: 6092
		private const int Crc24Poly = 25578747;

		// Token: 0x040017CD RID: 6093
		private int crc = 11994318;
	}
}
