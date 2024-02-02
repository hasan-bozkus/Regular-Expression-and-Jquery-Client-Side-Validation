using System.ComponentModel.DataAnnotations;

namespace Regular_Expression_and_Jquery_Client_Side_Validation.Models
{
    public class Img
    {
        [RegularExpression(@"(http(s?):)|([/|.|\w|\s])*\.(?:jpg|gif|png)")]
        public string FilePath { get; set; }
    }
}
