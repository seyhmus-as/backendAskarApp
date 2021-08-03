using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class GroupUserDto : IEntity
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public DateTime CreatedTime { get; set; }
		public string UserId { get; set; }
		public bool IsAdmin { get; set; }
	}
}
