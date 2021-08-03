using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{

	public class MessageManager : IMessageService
	{
		IMessageDal _messageDal;
		IChatDal _chatDal;
		public MessageManager(IMessageDal messageDal, IChatDal chatDal)
		{
			_messageDal = messageDal;
			_chatDal = chatDal;
		}

		public IResult Add(Message message)
		{
			_messageDal.Add(message);
			return new SuccessResult(Messages.MessageAdded);
		}

		public IResult Delete(int id)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Message>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Message>> GetById(int cardId)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<MessageChatUserDto>> GetMessagesByChatId(Guid senderChatId)
		{
			List<MessageChatUserDto> messages = _messageDal.GetMessageChatUserDtos();
			var a = _chatDal.Get(p => p.Id == senderChatId);

			messages = messages.FindAll(p => (p.SenderId == a.ReceiverId && p.ReceiverId == a.SenderId) || 
			(p.ReceiverId == a.ReceiverId && p.SenderId == a.SenderId));

			messages = messages
				.OrderBy(p => p.messageCreatedTime.Year)
				.ThenBy(p => p.messageCreatedTime.Month)
				.ThenBy(p => p.messageCreatedTime.Day)
				.ThenBy(p => p.messageCreatedTime.Hour)
				.ThenBy(p => p.messageCreatedTime.Minute)
				.ThenBy(p => p.messageCreatedTime.Second)
				.ThenBy(p => p.messageCreatedTime.Millisecond)
				.ToList();
			return new SuccessDataResult<List<MessageChatUserDto>>(messages, Messages.MessagesListed);
		}

		public IResult Update(Message Message)
		{
			throw new NotImplementedException();
		}
	}
}
