using System;

namespace SiliconApi.Common.DTO.Response
{
    public class UserResponse
    {
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public string FullName { get; set; }
        public string Identity { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}