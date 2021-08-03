using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class ChatUserDto:IEntity
	{
		public Guid? Id { get; set; }
		public Guid SenderId { get; set; }
		public Guid ReceiverId { get; set; }
		public DateTime CreatedTime { get; set; }


		public string SenderFirstName { get; set; }
		public string SenderLastName { get; set; }
		public string SenderEmail { get; set; }


		public string ReceiverFirstName { get; set; }
		public string ReceiverLastName { get; set; }
		public string ReceiverEmail { get; set; }
	}
}
