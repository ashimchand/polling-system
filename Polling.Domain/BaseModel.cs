﻿using System.ComponentModel.DataAnnotations;

namespace Polling.Domain
{
    public class BaseModel : RootModel
    {
        //Need to make this required after user table
        //[Required]
        public Guid? CreatedBy { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        public string? ModifiedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedDate { get; set; }
    }
}
