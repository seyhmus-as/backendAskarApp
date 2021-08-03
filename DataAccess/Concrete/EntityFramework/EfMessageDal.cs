using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMessageDal : EfEntityRepositoryBase<Message, AskarAppContext>,IMessageDal
    {   
        public List<MessageChatUserDto> GetMessageChatUserDtos()
        {
            using (AskarAppContext context = new AskarAppContext())
            {
                var result = from message in context.Messages
                             join chat in context.Chats
                             on message.ChatId equals chat.Id
                             join senderUser in context.Users
                             on chat.SenderId equals senderUser.Id
                             join receiverUser in context.Users
                             on chat.ReceiverId equals receiverUser.Id
                             select new MessageChatUserDto
                             {
                                 Id = message.Id,
                                 ChatId = chat.Id,
                                 Body = message.Body,
                                 SenderId = (Guid)senderUser.Id,
                                 chatCreatedTime  = chat.CreatedTime,
                                 IsDeleted = message.IsDeleted,
                                 SenderEmail = senderUser.Email,
                                 IsRead = message.IsRead,
                                 SenderFirstName = senderUser.FirstName,
                                 SenderLastName = senderUser.LastName,
                                 messageCreatedTime = message.CreatedTime,
                                 ReceiverEmail = receiverUser.Email,
                                 ReceiverFirstName = receiverUser.FirstName,
                                 ReceiverId = (Guid)receiverUser.Id,
                                 ReceiverLastName = receiverUser.LastName,
                             };
                var a = result.ToList();
                return a;
            }
        }
	}
}
