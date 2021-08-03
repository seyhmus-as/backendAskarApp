using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Message:IEntity
	{
		public Guid? Id { get; set; }
		public Guid? ChatId { get; set; }
		public string Body { get; set; }
		public DateTime CreatedTime { get; set; }
		public bool IsRead{ get; set; }
		public bool IsDeleted{ get; set; }
	}
}
