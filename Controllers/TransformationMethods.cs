using System.Text.RegularExpressions;
using LionWheelDataTransform.Models;
using LionWheelDataTransform.Models.Request;

namespace LionWheelDataTransform.Controllers
{
    public class TransformationMethods
    {
        public static RequestDataModel TransformData(RequestDataModel requestData)
        {
            var TransformedData = requestData;
            return TransformedData;
        }

        public static (string, string) SeparateAddress(string address)
        {

            address = address.Trim(); // trimming any whitespace from address

            // Regular expression to match the street number at the beginning of the address
            var regex = new Regex(@"^(\d+[A-Za-z]?)(\s*)(.*)");
            var match = regex.Match(address);

            if (match.Success && match.Groups.Count > 2)
            {
                // The street number is captured by the first group.
                string streetNumber = match.Groups[1].Value.Trim();
                // The rest of the address after any amount of whitespace is captured as the street name.
                string streetName = match.Groups[3].Value.Trim(); // Adjusted to capture the remainder of the address.

                return (streetNumber, streetName);
            }

            else
            {
                // Handle cases where no street number is found
                return (string.Empty, address);
            }
        }
    }
}
