using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfUserDal : EfEntityRepositoryBase<User, AskarAppContext>, IUserDal
	{
		public List<OperationClaim> GetClaims(User user)
		{
			using (var context = new AskarAppContext())
			{
				var result = from o in context.OperationClaims
							 join u in context.UserOperationClaims
								 on o.Id.ToString() equals u.OperationClaimId.ToString()
							 where u.UserId == user.Id
							 select new OperationClaim
							 {
								 Id = o.Id,
								 Name = o.Name
							 };
				return result.ToList();
			}
		}
		public List<UserDetailDto> GetUserDetails()
		{
			using (AskarAppContext context = new AskarAppContext())
			{
				var result = from o in context.UserOperationClaims
							 join u in context.Users
								on o.UserId equals u.Id
							 select new UserDetailDto
							 {
								 UserId = u.Id,
								 Email = u.Email,
								 FirstName = u.FirstName,
								 LastName = u.LastName,
								 OperationClaimId = o.OperationClaimId,
							 };
				return result.ToList();
			}
		}
		public List<UserForShowingDto> GetUserAll()
		{
			using (AskarAppContext context = new AskarAppContext())
			{
				var result = from u in context.Users
							 select new UserForShowingDto
							 {
								 UserId = u.Id,
								 Email = u.Email,
								 FirstName = u.FirstName,
								 LastName = u.LastName,
							 };
				return result.ToList();
			}
		}

	}
}
