using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCore.Models
{
    public class User
    {

        [Required(ErrorMessage = "Email 을 입력해주세요.")] // not null 처리
        //[MaxLength((30),ErrorMessage = "30글자이하로 입력해주세요.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "PassWord 를 입력해주세요.")] // not null 처리
        public string PW { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }

   
    }
}
