using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
	public class UserDetailDto
	{
		public Guid? UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public Guid OperationClaimId { get; set; }
		public string OperationName { get; set; }
	}
}