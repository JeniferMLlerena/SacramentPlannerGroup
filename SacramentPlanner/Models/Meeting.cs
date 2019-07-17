using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class Meeting
    {
        public int MeetingId { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        public string Conducting { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Display(Name = "Opening Prayer")]
        [Required]
        public string OpenPray { get; set; }

        [Range(1, 341)]
        [Display(Name = "Opening Hymn")]
        public string OpenHymn { get; set; }

        [Range(1, 341)]
        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }


        [Range(1, 341)]
        [Display(Name = "Intermediate Hymn")]
        public string IntermediateHymn { get; set; }

        [Range(1, 341)]
        [Display(Name = "Closing Hymn")]
        public string ClosingHymn { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Display(Name = "Closing Prayer")]
        [Required]
        public string ClosingPray { get; set; }

        
        /* navigation properties */
        public ICollection<Speaker> Speakers { get; set; }

    }
}
