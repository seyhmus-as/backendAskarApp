using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IMessageService
	{
		IResult Add(Message Message);
		IResult Delete(int id);
		IResult Update(Message Message);
		IDataResult<List<Message>> GetAll();
		IDataResult<List<Message>> GetById(int cardId);
		IDataResult<List<MessageChatUserDto>> GetMessagesByChatId(Guid senderChatId);
	}
}
