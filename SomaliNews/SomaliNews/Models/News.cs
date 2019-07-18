using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SomaliNews.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage ="This has to filled")]
        [MinLength( 2,ErrorMessage ="Can not be more than 2 letters")]
        [MaxLength (20, ErrorMessage =" Can not be more than 20 letters")]
        public string Title { get; set; }


        [Required(ErrorMessage = "This has to filled")]
        [MinLength(2, ErrorMessage = "Can not be more than 2 letters")]
        [MaxLength(5000, ErrorMessage = " Can not be more than 5000 letters")]
        public string NewsContant { get; set; }

        public DateTime NewsDate { get; set; } = DateTime.Now;

        public byte[] Image { get; set; }


        [Required(ErrorMessage = "This has to filled")]
        [MinLength(2, ErrorMessage = "Can not be more than 2 letters")]
        [MaxLength(20, ErrorMessage = " Can not be more than 20 letters")]
        public string Side { get; set; }

        [Required(ErrorMessage = "This has to filled")]
        [MinLength(2, ErrorMessage = "Can not be more than 2 letters")]
        [MaxLength(20, ErrorMessage = " Can not be more than 20 letters")]
        public string NewsReporter { get; set; }




    }
}