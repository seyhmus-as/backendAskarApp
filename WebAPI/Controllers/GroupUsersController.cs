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
	public class GroupUsersController : ControllerBase
	{
		IGroupUserService _GroupUserService;

		public GroupUsersController(IGroupUserService GroupUserService)
		{
			_GroupUserService = GroupUserService;
		}
		[HttpPost("add")]
		public IActionResult Add(GroupUser GroupUser)
		{
			var result = _GroupUserService.Add(GroupUser);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("update")]
		public IActionResult Update(GroupUser GroupUser)
		{
			var result = _GroupUserService.Update(GroupUser);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("delete")]
		public IActionResult Delete(int id)
		{
			var result = _GroupUserService.Delete(id);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _GroupUserService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpGet("getbyid")]
		public IActionResult GetById(int id)
		{
			var result = _GroupUserService.GetById(id);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpGet("details")]
		public IActionResult Details()
		{
			var result = _GroupUserService.GetGroupUserDetails();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}
