using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class MessageChatUserDto:IEntity
	{
		public Guid? Id { get; set; }
		public Guid? ChatId { get; set; }
		public string Body { get; set; }
		public DateTime messageCreatedTime { get; set; }
		public bool IsRead { get; set; }
		public bool IsDeleted { get; set; }

		public Guid SenderId { get; set; }
		public Guid ReceiverId { get; set; }
		public DateTime chatCreatedTime { get; set; }

		public string SenderFirstName { get; set; }
		public string SenderLastName { get; set; }
		public string SenderEmail { get; set; }

		public string ReceiverFirstName { get; set; }
		public string ReceiverLastName { get; set; }
		public string ReceiverEmail { get; set; }
	}
}
