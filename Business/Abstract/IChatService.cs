using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IChatService
    {
        IResult Add(Chat chat);
        IResult Delete(int id);
        IResult Update(Chat chat);
        IDataResult<List<Chat>> GetAll();
        IDataResult<Chat> GetById(Guid id);
        IDataResult<List<ChatUserDto>> GetChatByUser(string email);


    }
}
