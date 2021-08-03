using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class GroupManager : IGroupService
	{
		IGroupDal _GroupDal;
		public GroupManager(IGroupDal Groupdal)
		{
			_GroupDal = Groupdal;
		}

		public IResult Add(Group group)
		{
			throw new NotImplementedException();
		}

		public IResult Delete(int id)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Group>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IDataResult<Group> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Group group)
		{
			throw new NotImplementedException();
		}
	}
}
