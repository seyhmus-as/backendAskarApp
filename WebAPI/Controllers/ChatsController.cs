using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ChatsController : ControllerBase
	{
		IChatService _chatService;
		public ChatsController(IChatService ChatService)
		{
			_chatService = ChatService;
		}
		[HttpPost("add")]
		public IActionResult Add(Chat chat)
		{
			var result = _chatService.Add(chat);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("update")]
		public IActionResult Update(Chat Chat)
		{
			var result = _chatService.Update(Chat);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("delete")]
		public IActionResult Delete(int id)
		{
			var result = _chatService.Delete(id);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _chatService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpGet("getbyid")]
		public IActionResult GetById(Guid user)
		{
			var result = _chatService.GetById(user);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpGet("getchatbyuser")]
		public IActionResult GetChatByUser(String email)
		{
			var result = _chatService.GetChatByUser(email);
			if (result.Success)
			{
				return Ok(result);	
			}
			return BadRequest(result);
		}

	}
}
