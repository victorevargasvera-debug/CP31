using System;
using System.Drawing;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x0200019B RID: 411
	internal class Marker : global::Gibraltar.Monitor.Internal.IDisplayable, global::System.IComparable<global::Gibraltar.Monitor.Marker>, global::System.IEquatable<global::Gibraltar.Monitor.Marker>
	{
		// Token: 0x060011E5 RID: 4581 RVA: 0x00033628 File Offset: 0x00031828
		public Marker(global::Gibraltar.Monitor.Analysis analysis)
		{
			this.m_Analysis = analysis;
			this.m_Packet = new global::Gibraltar.Monitor.Internal.MarkerPacket();
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x00033644 File Offset: 0x00031844
		public global::Gibraltar.Monitor.Analysis Analysis
		{
			get
			{
				return this.m_Analysis;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x0003364C File Offset: 0x0003184C
		public global::System.Guid Id
		{
			get
			{
				return this.m_Packet.ID;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x0003365C File Offset: 0x0003185C
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x0003366C File Offset: 0x0003186C
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

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x00033698 File Offset: 0x00031898
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x000336A8 File Offset: 0x000318A8
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

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x000336D4 File Offset: 0x000318D4
		// (set) Token: 0x060011ED RID: 4589 RVA: 0x000336E4 File Offset: 0x000318E4
		public global::System.Drawing.Color Color
		{
			get
			{
				return this.m_Packet.Color;
			}
			set
			{
				this.m_Packet.Color = value;
			}
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x000336F4 File Offset: 0x000318F4
		public int CompareTo(global::Gibraltar.Monitor.Marker other)
		{
			if (this.Id == other.Id)
			{
				return 0;
			}
			int num = string.Compare(this.Caption, other.Caption, global::System.StringComparison.InvariantCulture);
			if (num == 0)
			{
				num = string.Compare(this.Description, other.Description, global::System.StringComparison.InvariantCulture);
			}
			return num;
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0003374C File Offset: 0x0003194C
		public bool Equals(global::Gibraltar.Monitor.Marker other)
		{
			return other != null && this.Id == other.Id;
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00033768 File Offset: 0x00031968
		public override bool Equals(object obj)
		{
			global::Gibraltar.Monitor.Marker other = obj as global::Gibraltar.Monitor.Marker;
			return this.Equals(other);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00033788 File Offset: 0x00031988
		public override int GetHashCode()
		{
			return this.Id.GetHashCode();
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x000337B0 File Offset: 0x000319B0
		public static bool operator ==(global::Gibraltar.Monitor.Marker left, global::Gibraltar.Monitor.Marker right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x000337C4 File Offset: 0x000319C4
		public static bool operator !=(global::Gibraltar.Monitor.Marker left, global::Gibraltar.Monitor.Marker right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x000337DC File Offset: 0x000319DC
		public static bool operator <(global::Gibraltar.Monitor.Marker left, global::Gibraltar.Monitor.Marker right)
		{
			return left.CompareTo(right) < 0;
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x000337E8 File Offset: 0x000319E8
		public static bool operator >(global::Gibraltar.Monitor.Marker left, global::Gibraltar.Monitor.Marker right)
		{
			return left.CompareTo(right) > 0;
		}

		// Token: 0x0400060E RID: 1550
		private readonly global::Gibraltar.Monitor.Analysis m_Analysis;

		// Token: 0x0400060F RID: 1551
		private readonly global::Gibraltar.Monitor.Internal.MarkerPacket m_Packet;
	}
}
