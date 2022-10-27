//Manuel L.
//10-25-22
//Greater Than Or Less Than 
//The user will input two numbers, and the code will tell the user if it 
//is greater than, less than, or equal too
//Peer Review: Reed Goodwin- Good solid code that followed the guidelines, 
//i like the way it tells you all the variations of the answer

using Microsoft.AspNetCore.Mvc;

namespace LeyvaM.GTOLTEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class GTOLTController : ControllerBase
{
    [HttpGet]
    [Route("MiniCh4/{number1}/{number2}")]

    public string Greater(string number1, string number2)
    {
        string result = "";
        int rNum11 = Convert.ToInt32(number1);
        int rNum12 = Convert.ToInt32(number2);
        if (rNum11 > rNum12)
        {
            result = ($"{rNum11} is greater than {rNum12} \n {rNum12} is less than {rNum11} \n {rNum11} is not equal to {rNum12}");

        }
        if (rNum11 < rNum12)
        {
            result = ($"{rNum11} is less than {rNum12} \n {rNum12} is greater than {rNum11} \n {rNum11} is not equal to {rNum12}");

        }
        if (rNum11 == rNum12)
        {
            result = ($"{rNum11} is not less than {rNum12} \n {rNum12} is not greater than {rNum11} \n {rNum11} is equal to {rNum12}");

        }
        return result;

    }
}
