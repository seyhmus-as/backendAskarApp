using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
	public static class Messages
	{
		public static string MessageAdded = "Message Added";
		public static string ChatAdded = "Chat Added";
		public static string GroupAdded = "Group Added";
		public static string GroupUserAdded = "GroupUser Added";
		public static string MessageDeleted = "Message Deleted";
		public static string ChatDeleted = "Chat Deleted";
		public static string GroupDeleted = "Group Deleted";
		public static string GroupUserDeleted = "GroupUser Deleted";
		public static string MessageUpdate = "Message Update";
		public static string GroupUpdated = "Group Updated";
		public static string ChatUpdated = "Chat Updated";
		public static string GroupUserUpdated = "GroupUser Updated";
		public static string GroupUsersListed = "GroupUser Listed";
		public static string GroupsListed = "Group Listed";
		public static string MessagesListed = "Messages Listed";
		public static string ChatsListed = "Chats Listed";
		public static string MessageViewedById = "Message Viewed By Id";
		public static string GroupViewedById = "Group Viewed By Id";
		public static string GroupUserViewedById = "GroupUser Viewed By Id";
		public static string ChatViewed = "Chat Viewed";
		public static string GroupUserNameMustStartA = "GroupUser Name Must Start A";
		public static string GroupUserNameNotNull = "GroupUser Name Not Null";
		public static string AuthorizationDenied = "Authorization Denied";
		public static string UsersListed = "Users Listed";
		public static string OperationClaimsListed = "Operation Claims Listed";
		public static string UserDeleted = "User Deleted";
		public static string UserOperationClaimDeleted = "User Operation Claim Deleted";
		public static string UserOperationClaimUpdated = "User Operation Claim Updated";
		public static string UserOperationClaimsListed = "User Operation Claims Listed";
		public static string UserOperationClaimAdded = "User Operation Claim Added";
		public static string UserNotFound = "User Not Found";
		public static string WrongPassword = "Wrong Password";
		public static string SuccessLogin = "Success Login";
		public static string EmailUsed = "This Email Is Already Being Used";
	}
}
