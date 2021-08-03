using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfChatDal : EfEntityRepositoryBase<Chat, AskarAppContext>, IChatDal
    {
		public List<ChatUserDto> GetChatUserDto()
		{
			using (AskarAppContext context = new AskarAppContext())
			{
                var result = from chat in context.Chats
                             join senderUser in context.Users
                             on chat.SenderId equals senderUser.Id
                             join receiverUser in context.Users
                             on chat.ReceiverId equals receiverUser.Id
                             select new ChatUserDto
                             {
                                 Id = chat.Id,
                                 CreatedTime = chat.CreatedTime,
                                 SenderId = (Guid)senderUser.Id,
                                 SenderEmail = senderUser.Email,
                                 SenderFirstName = senderUser.FirstName,
                                 SenderLastName = senderUser.LastName,
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