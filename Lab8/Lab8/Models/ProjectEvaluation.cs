using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab8.Models
{
    public class ProjectEvaluation
    {
       // [MaxWordsAttribute(3)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
      //  [MinWordsAttribute(2)]
        public string City { get; set; }

        public string Country { get; set; }

        [Range(1, 10)]
        [Required]
        public double Rating { get; set; }

        public int Id { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Rating < 2 && Name.ToLower().StartsWith("john"))
                yield return new ValidationResult("Sorry !!!");
        }

        public IEnumerable<ValidationResult> Validare(ValidationContext validationContext)
        {
            if (Rating > 8 && Name.ToLower().StartsWith("alina"))
                yield return new ValidationResult("Goog!!!");
        }
    }
}