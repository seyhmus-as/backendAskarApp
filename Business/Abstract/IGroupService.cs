using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IGroupService
	{
		IResult Add(Group group);
		IResult Delete(int id);
		IResult Update(Group group);
		IDataResult<List<Group>> GetAll();
		IDataResult<Group> GetById(int id);
	}
}
