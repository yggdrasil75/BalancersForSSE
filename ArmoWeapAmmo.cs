using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YggScripting_partial_standalone
{
	abstract class Item
	{
		public int Value { get; }
		public float Weight { get; }
		public string[] Keywords { get; }

		protected Item(int value, float weight, string[] keywords)
		{
			Value = value;
			Weight = weight;
			Keywords = keywords;
		}
		public abstract string[] Address { get; }
	}
	class Armo : Item
	{
		public int Rating { get; }
		public string Slot { get; }

		public Armo(int rating, int value, float weight, string[] keywords) : base(value, weight, keywords)
		{
			Rating = rating;
		}
		public override string[] Address
		{
			get
			{
				string[] addresses = new string[Keywords.Count()];
				for (int i = 0; i <= Keywords.Count(); i++)
				{
					addresses[i] = Keywords[i] + Slot;
				}
				return addresses;
			}
		}
	}
	class Weap : Item
	{
		public int damage { get; }
		public float speed { get; }
		public float reach { get; }
		public int crdt { get; }
		public string type { get; }

		public Weap(int damage, float speed, float reach, int crdt, int value, float weight, string[] keywords, string type) : base(value, weight, keywords)
		{
			this.damage = damage;
			this.speed = speed;
			this.reach = reach;
			this.crdt = crdt;
			this.type = type;
		}
		public override string[] Address
		{
			get
			{
				string[] addresses = new string[Keywords.Count()];
				for (int i = 0; i <= Keywords.Count(); i++)
				{
					addresses[i] = Keywords[i] + type;
				}
				return addresses;
			}
		}
	}
	class Ammo : Item
	{
		public int damage { get; }
		public bool AB { get; }

		public Ammo(int damage, int value, float weight, string[] keywords, string ab) : base(value, weight, keywords)
		{
			this.damage = damage;
			if (ab.Equals("arrow")) AB = true;
			else AB = false;
		}
		public override string[] Address
		{
			get
			{
				string[] addresses = new string[Keywords.Count()];
				if (AB)
				{
					for (int i = 0; i <= Keywords.Count(); i++)
					{
						addresses[i] = Keywords[i] + "bolt";
					}
				}
				else
				{
					for (int i = 0; i <= Keywords.Count(); i++)
					{
						{
							addresses[i] = Keywords[i] + "Arrow";
						}
					}
				}
				return addresses;
			}
		}
	}
	class Bow : Weap
	{
		public float RangeMin { get; }
		public float RangeMax { get; }

		public Bow(float rangeMin, float rangeMax, int damage, float speed, float reach, int crdt, int value, float weight, string[] keywords, string type) : base(damage, speed, reach, crdt, value, weight, keywords, type)
		{
			RangeMin = rangeMin;
			RangeMax = rangeMax;
		}
		public override string[] Address
		{
			get
			{
				string[] addresses = new string[Keywords.Count()];
				for (int i = 0; i <= Keywords.Count(); i++)
				{
					addresses[i] = Keywords[i] + type;
				}
				return addresses;
			}
		}
	}
}
