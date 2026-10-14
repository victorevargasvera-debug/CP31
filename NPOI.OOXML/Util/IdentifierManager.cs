using System;
using System.Collections.Generic;

namespace NPOI.Util
{
	// Token: 0x020000ED RID: 237
	public class IdentifierManager
	{
		// Token: 0x06000EB1 RID: 3761 RVA: 0x000332BC File Offset: 0x000314BC
		public IdentifierManager(long lowerbound, long upperbound)
		{
			if (lowerbound > upperbound)
			{
				throw new global::System.ArgumentException("lowerbound must not be greater than upperbound, had " + lowerbound.ToString() + " and " + upperbound.ToString());
			}
			if (lowerbound < global::NPOI.Util.IdentifierManager.MIN_ID)
			{
				throw new global::System.ArgumentException("lowerbound must be greater than or equal to " + global::NPOI.Util.IdentifierManager.MIN_ID.ToString());
			}
			if (upperbound > global::NPOI.Util.IdentifierManager.MAX_ID)
			{
				throw new global::System.ArgumentException("upperbound must be less than or equal to " + global::NPOI.Util.IdentifierManager.MAX_ID.ToString() + " but had " + upperbound.ToString());
			}
			this.lowerbound = lowerbound;
			this.upperbound = upperbound;
			this.segments = new global::System.Collections.Generic.List<global::NPOI.Util.IdentifierManager.Segment>();
			this.segments.Add(new global::NPOI.Util.IdentifierManager.Segment(lowerbound, upperbound));
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00033374 File Offset: 0x00031574
		public long Reserve(long id)
		{
			if (id < this.lowerbound || id > this.upperbound)
			{
				throw new global::System.ArgumentException("Value for parameter 'id' was out of bounds");
			}
			this.VerifyIdentifiersLeft();
			if (id == this.upperbound)
			{
				int index = this.segments.Count - 1;
				global::NPOI.Util.IdentifierManager.Segment segment = this.segments[index];
				if (segment.end == this.upperbound)
				{
					segment.end = this.upperbound - 1L;
					if (segment.start > segment.end)
					{
						this.segments.RemoveAt(index);
					}
					return id;
				}
				return this.ReserveNew();
			}
			else
			{
				if (id != this.lowerbound)
				{
					int i = 0;
					while (i < this.segments.Count)
					{
						global::NPOI.Util.IdentifierManager.Segment segment2 = this.segments[i];
						if (segment2.end >= id)
						{
							if (segment2.start > id)
							{
								break;
							}
							if (segment2.start == id)
							{
								segment2.start = id + 1L;
								if (segment2.end < segment2.start)
								{
									this.segments.Remove(segment2);
								}
								return id;
							}
							if (segment2.end == id)
							{
								segment2.end = id - 1L;
								if (segment2.start > segment2.end)
								{
									this.segments.Remove(segment2);
								}
								return id;
							}
							this.segments.Add(new global::NPOI.Util.IdentifierManager.Segment(id + 1L, segment2.end));
							segment2.end = id - 1L;
							return id;
						}
						else
						{
							i++;
						}
					}
					return this.ReserveNew();
				}
				global::NPOI.Util.IdentifierManager.Segment segment3 = this.segments[0];
				if (segment3.start == this.lowerbound)
				{
					segment3.start = this.lowerbound + 1L;
					if (segment3.end < segment3.start)
					{
						this.segments.RemoveAt(0);
					}
					return id;
				}
				return this.ReserveNew();
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0003353C File Offset: 0x0003173C
		public long ReserveNew()
		{
			this.VerifyIdentifiersLeft();
			global::NPOI.Util.IdentifierManager.Segment segment = this.segments[0];
			long start = segment.start;
			segment.start += 1L;
			if (segment.start > segment.end)
			{
				this.segments.RemoveAt(0);
			}
			return start;
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0003358C File Offset: 0x0003178C
		public bool Release(long id)
		{
			if (id < this.lowerbound || id > this.upperbound)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Value for parameter 'id' was out of bounds, had ",
					id.ToString(),
					", but should be within [",
					this.lowerbound.ToString(),
					":",
					this.upperbound.ToString(),
					"]"
				}));
			}
			if (id == this.upperbound)
			{
				int index = this.segments.Count - 1;
				global::NPOI.Util.IdentifierManager.Segment segment = this.segments[index];
				if (segment.end == this.upperbound - 1L)
				{
					segment.end = this.upperbound;
					return true;
				}
				if (segment.end == this.upperbound)
				{
					return false;
				}
				this.segments.Add(new global::NPOI.Util.IdentifierManager.Segment(this.upperbound, this.upperbound));
				return true;
			}
			else
			{
				if (id != this.lowerbound)
				{
					long num = id + 1L;
					long num2 = id - 1L;
					int i = 0;
					while (i < this.segments.Count)
					{
						global::NPOI.Util.IdentifierManager.Segment segment2 = this.segments[0];
						if (segment2.end >= num2)
						{
							if (segment2.start > num)
							{
								this.segments.Insert(i, new global::NPOI.Util.IdentifierManager.Segment(id, id));
								return true;
							}
							if (segment2.start == num)
							{
								segment2.start = id;
								return true;
							}
							if (segment2.end == num2)
							{
								segment2.end = id;
								if (i + 1 < this.segments.Count)
								{
									global::NPOI.Util.IdentifierManager.Segment segment3 = this.segments[i + 1];
									if (segment3.start == segment2.end + 1L)
									{
										segment2.end = segment3.end;
										this.segments.Remove(segment3);
									}
								}
								return true;
							}
							break;
						}
						else
						{
							i++;
						}
					}
					return false;
				}
				global::NPOI.Util.IdentifierManager.Segment segment4 = this.segments[0];
				if (segment4.start == this.lowerbound + 1L)
				{
					segment4.start = this.lowerbound;
					return true;
				}
				if (segment4.start == this.lowerbound)
				{
					return false;
				}
				this.segments.Insert(0, new global::NPOI.Util.IdentifierManager.Segment(this.lowerbound, this.lowerbound));
				return true;
			}
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x000337BC File Offset: 0x000319BC
		public long GetRemainingIdentifiers()
		{
			long num = 0L;
			foreach (global::NPOI.Util.IdentifierManager.Segment segment in this.segments)
			{
				num -= segment.start;
				num = num + segment.end + 1L;
			}
			return num;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00033824 File Offset: 0x00031A24
		private void VerifyIdentifiersLeft()
		{
			if (this.segments.Count == 0)
			{
				throw new global::System.InvalidOperationException("No identifiers left");
			}
		}

		// Token: 0x0400045C RID: 1116
		public static long MAX_ID = 9223372036854775806L;

		// Token: 0x0400045D RID: 1117
		public static long MIN_ID = 0L;

		// Token: 0x0400045E RID: 1118
		private long upperbound;

		// Token: 0x0400045F RID: 1119
		private long lowerbound;

		// Token: 0x04000460 RID: 1120
		private global::System.Collections.Generic.List<global::NPOI.Util.IdentifierManager.Segment> segments;

		// Token: 0x0200014D RID: 333
		internal class Segment
		{
			// Token: 0x06001076 RID: 4214 RVA: 0x0003944C File Offset: 0x0003764C
			public Segment(long start, long end)
			{
				this.start = start;
				this.end = end;
			}

			// Token: 0x06001077 RID: 4215 RVA: 0x00039464 File Offset: 0x00037664
			public override string ToString()
			{
				return string.Concat(new string[]
				{
					"[",
					this.start.ToString(),
					"; ",
					this.end.ToString(),
					"]"
				});
			}

			// Token: 0x04000536 RID: 1334
			public long start;

			// Token: 0x04000537 RID: 1335
			public long end;
		}
	}
}
