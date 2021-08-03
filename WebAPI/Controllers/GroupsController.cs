using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GroupsController : ControllerBase
	{
		IGroupService _GroupService;
		public GroupsController(IGroupService GroupService)
		{
			_GroupService = GroupService; 
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _GroupService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);

		}

		[HttpGet("getbyid")]
		public IActionResult GetById(int GroupId)
		{
			var result = _GroupService.GetById(GroupId);
			if (result.Success)
			{
				return Ok(result);
			}

			return BadRequest(result);
		}

		[HttpPost("add")]
		public IActionResult Add(Group Group)
		{
			var result = _GroupService.Add(Group);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("update")]
		public IActionResult Update(Group Group)
		{
			var result = _GroupService.Update(Group);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("delete")]
		public IActionResult Delete(int id)
		{
			var result = _GroupService.Delete(id);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

	}
}
