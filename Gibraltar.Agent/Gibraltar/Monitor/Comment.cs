using System;
using System.Globalization;
using System.Windows.Forms;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x02000186 RID: 390
	internal class Comment : global::Gibraltar.Monitor.Internal.IDisplayable, global::System.IComparable<global::Gibraltar.Monitor.Comment>, global::System.IEquatable<global::Gibraltar.Monitor.Comment>
	{
		// Token: 0x06001049 RID: 4169 RVA: 0x0002D19C File Offset: 0x0002B39C
		public Comment()
		{
			this.m_Packet = new global::Gibraltar.Monitor.Internal.CommentPacket();
			this.m_Packet.Timestamp = global::System.DateTimeOffset.Now;
			this.m_Packet.Id = global::System.Guid.NewGuid();
			this.m_Packet.UserName = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}\\{1}", new object[]
			{
				global::System.Windows.Forms.SystemInformation.UserDomainName,
				global::System.Windows.Forms.SystemInformation.UserName
			});
			this.m_Packet.Caption = string.Empty;
			this.m_Packet.Description = string.Empty;
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0002D230 File Offset: 0x0002B430
		public Comment(string caption, string description) : this()
		{
			this.m_Packet.Caption = caption;
			this.m_Packet.Description = description;
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x0002D250 File Offset: 0x0002B450
		public global::System.Guid Id
		{
			get
			{
				return this.m_Packet.Id;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x0002D260 File Offset: 0x0002B460
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x0002D270 File Offset: 0x0002B470
		public string Caption
		{
			get
			{
				return this.m_Packet.Caption;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					this.m_Packet.Caption = value;
					return;
				}
				this.m_Packet.Caption = value.Trim();
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x0002D29C File Offset: 0x0002B49C
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x0002D2AC File Offset: 0x0002B4AC
		public string Description
		{
			get
			{
				return this.m_Packet.Description;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					this.m_Packet.Description = value;
					return;
				}
				this.m_Packet.Description = value.Trim();
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x0002D2D8 File Offset: 0x0002B4D8
		public global::System.DateTimeOffset TimeStamp
		{
			get
			{
				return this.m_Packet.Timestamp;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x0002D2E8 File Offset: 0x0002B4E8
		public string UserName
		{
			get
			{
				return this.m_Packet.UserName;
			}
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0002D2F8 File Offset: 0x0002B4F8
		public int CompareTo(global::Gibraltar.Monitor.Comment other)
		{
			if (this.Id == other.Id)
			{
				return 0;
			}
			int num = this.TimeStamp.CompareTo(other.TimeStamp);
			if (num == 0)
			{
				num = string.Compare(this.Caption, other.Caption, global::System.StringComparison.InvariantCulture);
				if (num == 0)
				{
					num = string.Compare(this.Description, other.Description, global::System.StringComparison.InvariantCulture);
					if (num == 0)
					{
						num = string.Compare(this.UserName, other.UserName, global::System.StringComparison.InvariantCulture);
					}
				}
			}
			return num;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0002D384 File Offset: 0x0002B584
		public bool Equals(global::Gibraltar.Monitor.Comment other)
		{
			return other != null && this.m_Packet.Id == other.Id;
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0002D3A4 File Offset: 0x0002B5A4
		public override bool Equals(object obj)
		{
			global::Gibraltar.Monitor.Comment other = obj as global::Gibraltar.Monitor.Comment;
			return this.Equals(other);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0002D3C4 File Offset: 0x0002B5C4
		public override int GetHashCode()
		{
			return this.m_Packet.Id.GetHashCode();
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0002D3F0 File Offset: 0x0002B5F0
		public static bool operator ==(global::Gibraltar.Monitor.Comment left, global::Gibraltar.Monitor.Comment right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0002D404 File Offset: 0x0002B604
		public static bool operator !=(global::Gibraltar.Monitor.Comment left, global::Gibraltar.Monitor.Comment right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0002D41C File Offset: 0x0002B61C
		public static bool operator <(global::Gibraltar.Monitor.Comment left, global::Gibraltar.Monitor.Comment right)
		{
			return left.CompareTo(right) < 0;
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0002D428 File Offset: 0x0002B628
		public static bool operator >(global::Gibraltar.Monitor.Comment left, global::Gibraltar.Monitor.Comment right)
		{
			return left.CompareTo(right) > 0;
		}

		// Token: 0x0400057C RID: 1404
		private readonly global::Gibraltar.Monitor.Internal.CommentPacket m_Packet;
	}
}
