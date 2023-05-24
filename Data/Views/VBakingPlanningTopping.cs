using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingStore.Data.Views;

public class VBakingPlanningTopping
{
	public int Id { get; set; }
	public int BakingPlanId { get; set; }
	public int ToppingId { get; set; }
	public int Qty { get; set; }
	public string ToppingName { get; set; }
	public string ToppingUomCode { get; set; }
	public float ToppingAvailableStock { get; set; }
}
