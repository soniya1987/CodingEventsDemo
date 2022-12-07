using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.Viewmodels
{
    public class AddEventCategoryViewModel
    {
        [Required(ErrorMessage ="Event category name is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Event category name should be between 3 and 20 characters long")]
        public string Name { get; set; }

        public AddEventCategoryViewModel()
        {

        }


    }
}
