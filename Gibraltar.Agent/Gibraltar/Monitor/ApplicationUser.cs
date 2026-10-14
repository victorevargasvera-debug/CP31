using System;
using System.Collections.Generic;
using System.Diagnostics;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x0200017E RID: 382
	[global::System.Diagnostics.DebuggerDisplay("User {Key} : {FullyQualifiedUserName}")]
	internal class ApplicationUser : global::System.IComparable<global::Gibraltar.Monitor.ApplicationUser>, global::System.IEquatable<global::Gibraltar.Monitor.ApplicationUser>, global::Loupe.Extensibility.Data.IApplicationUser
	{
		// Token: 0x06000FD6 RID: 4054 RVA: 0x0002B614 File Offset: 0x00029814
		internal ApplicationUser(string userName, global::System.DateTimeOffset timestamp, long sequence)
		{
			this.m_Packet = new global::Gibraltar.Monitor.Internal.ApplicationUserPacket
			{
				Timestamp = timestamp,
				Sequence = sequence,
				FullyQualifiedUserName = userName
			};
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0002B64C File Offset: 0x0002984C
		internal ApplicationUser(global::Gibraltar.Monitor.Internal.ApplicationUserPacket packet)
		{
			this.m_Packet = packet;
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x0002B65C File Offset: 0x0002985C
		internal global::Gibraltar.Monitor.Internal.ApplicationUserPacket Packet
		{
			get
			{
				return this.m_Packet;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x0002B664 File Offset: 0x00029864
		public global::System.Guid Id
		{
			get
			{
				return this.m_Packet.ID;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x0002B674 File Offset: 0x00029874
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x0002B684 File Offset: 0x00029884
		public string Key
		{
			get
			{
				return this.m_Packet.Key;
			}
			set
			{
				this.m_Packet.Key = value;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x0002B694 File Offset: 0x00029894
		public string FullyQualifiedUserName
		{
			get
			{
				return this.m_Packet.FullyQualifiedUserName;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x0002B6A4 File Offset: 0x000298A4
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x0002B6B4 File Offset: 0x000298B4
		public string Caption
		{
			get
			{
				return this.m_Packet.Caption;
			}
			set
			{
				this.m_Packet.Caption = value;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x0002B6C4 File Offset: 0x000298C4
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x0002B6D4 File Offset: 0x000298D4
		public string Title
		{
			get
			{
				return this.m_Packet.Title;
			}
			set
			{
				this.m_Packet.Title = value;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x0002B6E4 File Offset: 0x000298E4
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x0002B6F4 File Offset: 0x000298F4
		public string EmailAddress
		{
			get
			{
				return this.m_Packet.EmailAddress;
			}
			set
			{
				this.m_Packet.EmailAddress = value;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x0002B704 File Offset: 0x00029904
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x0002B714 File Offset: 0x00029914
		public string Phone
		{
			get
			{
				return this.m_Packet.Phone;
			}
			set
			{
				this.m_Packet.Phone = value;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x0002B724 File Offset: 0x00029924
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x0002B734 File Offset: 0x00029934
		public string Organization
		{
			get
			{
				return this.m_Packet.Organization;
			}
			set
			{
				this.m_Packet.Organization = value;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x0002B744 File Offset: 0x00029944
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x0002B754 File Offset: 0x00029954
		public string Role
		{
			get
			{
				return this.m_Packet.Role;
			}
			set
			{
				this.m_Packet.Role = value;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x0002B764 File Offset: 0x00029964
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x0002B774 File Offset: 0x00029974
		public string Tenant
		{
			get
			{
				return this.m_Packet.Tenant;
			}
			set
			{
				this.m_Packet.Tenant = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x0002B784 File Offset: 0x00029984
		// (set) Token: 0x06000FEC RID: 4076 RVA: 0x0002B794 File Offset: 0x00029994
		public string TimeZoneCode
		{
			get
			{
				return this.m_Packet.TimeZoneCode;
			}
			set
			{
				this.m_Packet.TimeZoneCode = value;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x0002B7A4 File Offset: 0x000299A4
		public global::System.Collections.Generic.Dictionary<string, string> Properties
		{
			get
			{
				return this.m_Packet.Properties;
			}
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0002B7B4 File Offset: 0x000299B4
		public int CompareTo(global::Gibraltar.Monitor.ApplicationUser other)
		{
			if (other == null)
			{
				return 1;
			}
			if (this == other)
			{
				return 0;
			}
			int num = string.Compare(this.FullyQualifiedUserName, other.FullyQualifiedUserName, global::System.StringComparison.OrdinalIgnoreCase);
			if (num == 0 && !string.IsNullOrEmpty(this.Key))
			{
				num = string.Compare(this.Key, other.Key, global::System.StringComparison.OrdinalIgnoreCase);
			}
			return num;
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0002B814 File Offset: 0x00029A14
		public bool Equals(global::Gibraltar.Monitor.ApplicationUser other)
		{
			return this.CompareTo(other) == 0;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0002B828 File Offset: 0x00029A28
		public override bool Equals(object obj)
		{
			global::Gibraltar.Monitor.ApplicationUser other = obj as global::Gibraltar.Monitor.ApplicationUser;
			return this.Equals(other);
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0002B848 File Offset: 0x00029A48
		public override int GetHashCode()
		{
			if (!string.IsNullOrEmpty(this.Key))
			{
				return this.Key.GetHashCode();
			}
			return this.FullyQualifiedUserName.GetHashCode();
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0002B874 File Offset: 0x00029A74
		public static bool operator ==(global::Gibraltar.Monitor.ApplicationUser left, global::Gibraltar.Monitor.ApplicationUser right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0002B888 File Offset: 0x00029A88
		public static bool operator !=(global::Gibraltar.Monitor.ApplicationUser left, global::Gibraltar.Monitor.ApplicationUser right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0002B8A0 File Offset: 0x00029AA0
		public static bool operator <(global::Gibraltar.Monitor.ApplicationUser left, global::Gibraltar.Monitor.ApplicationUser right)
		{
			return left.CompareTo(right) < 0;
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0002B8AC File Offset: 0x00029AAC
		public static bool operator >(global::Gibraltar.Monitor.ApplicationUser left, global::Gibraltar.Monitor.ApplicationUser right)
		{
			return left.CompareTo(right) > 0;
		}

		// Token: 0x04000557 RID: 1367
		private readonly global::Gibraltar.Monitor.Internal.ApplicationUserPacket m_Packet;
	}
}
