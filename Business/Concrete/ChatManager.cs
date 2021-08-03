using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class ChatManager : IChatService
	{
		IChatDal _chatDal;
		IUserDal _userDal;
		public ChatManager(IChatDal chatDal, IUserDal userDal)
		{
			_chatDal = chatDal;
			_userDal = userDal;
		}

		public IResult Add(Chat chat)
		{
			_chatDal.Add(chat); 
			return new SuccessResult(Messages.ChatAdded);
		}

		public IResult Delete(int id)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Chat>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IDataResult<Chat> GetById(Guid id)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<ChatUserDto>> GetChatByUser(string email)
		{
			List<ChatUserDto> chat = _chatDal.GetChatUserDto();
			chat = chat.FindAll(x => x.SenderEmail == email);
			return new SuccessDataResult<List<ChatUserDto>>(chat, Messages.ChatsListed);
		}

		public IResult Update(Chat chat)
		{
			throw new NotImplementedException();
		}

		public UserForShowingDto GetByEmail(string email)
		{
			User a = _userDal.Get(p => p.Email == email);
			UserForShowingDto baaa = new UserForShowingDto
			{
				Email = email,
				FirstName = a.FirstName,
				LastName = a.LastName,
				UserId = a.Id,
			};

			return baaa;
		}
	}
}