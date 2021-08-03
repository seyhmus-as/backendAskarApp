using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class GroupUserManager : IGroupUserService
	{
		IGroupUserDal _GroupUserDal;
		public GroupUserManager(IGroupUserDal GroupUserdal)
		{
			_GroupUserDal = GroupUserdal;
		}

		public IResult Add(GroupUser GroupUser)
		{
			throw new NotImplementedException();
		}

		public IResult Delete(int id)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<GroupUser>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<GroupUser>> GetById(int GroupUserId)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<GroupUserDto>> GetGroupUserDetails()
		{
			throw new NotImplementedException();
		}

		public IResult Update(GroupUser GroupUser)
		{
			throw new NotImplementedException();
		}
	}
}