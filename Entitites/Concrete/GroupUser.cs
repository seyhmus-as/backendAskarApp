using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class GroupUser:IEntity
	{
		public Guid? Id { get; set; }
		public string UserId { get; set; }
		public bool IsAdmin{ get; set; }
	}
}
