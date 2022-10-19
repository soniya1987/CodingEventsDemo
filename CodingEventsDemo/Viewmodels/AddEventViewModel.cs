using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.Viewmodels
{
    public class AddEventViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Location information is required.")]
        public string Location { get; set; }
        [Range(0, 100000, ErrorMessage ="Number of attendees should be between zero and 100,000")]
        public int NumberOfAttendees { get; set; }
        [Compare("whether an attendee must register for the event or not")]
        public bool IsTrue { get { return true; } }
    }
}
