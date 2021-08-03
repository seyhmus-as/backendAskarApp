using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Chat:IEntity
	{
		public Guid? Id { get; set; }
		public Guid SenderId { get; set; }
		public Guid ReceiverId { get; set; }
		public DateTime CreatedTime { get; set; }
	}
}
