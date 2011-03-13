﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace pjank.BossaAPI
{
	/// <summary>
	/// Lista bieżących zleceń na danym rachunku.
	/// </summary>
	public class BosOrders : IEnumerable<BosOrder>
	{
		private List<BosOrder> list = new List<BosOrder>();

		public int Count
		{
			get { return list.Count; }
		}

		public BosOrder this[int index]
		{
			get { return list[index]; }
		}

		public IEnumerator<BosOrder> GetEnumerator()
		{
			for (int i = 0; i < Count; i++)
				yield return this[i];
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		// aktualizacja danych na liście po odebraniu ich z sieci
		internal void Update(DTO.OrderData data)
		{
			var order = list.Where(o => o.Id == data.BrokerId).SingleOrDefault();
			if (order != null)
				order.Update(data);
			else 
				list.Add(new BosOrder(data));
		}
	}
}
