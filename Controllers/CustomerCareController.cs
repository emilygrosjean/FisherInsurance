using Microsoft.AspNetCore.Mvc;


[Route("customer")]
public class CustomerCareController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the CustomerCareController");
    }

    [Route("claims")]
    public IActionResult Quote()
    {
        return Ok("This is the claims page of the CustomerCareController");
    }

    [Route("fileclaim")]
    public IActionResult NewClaim()
    {
        return Ok("This is the fileclaim page of the CustomerCareController");
    }

    [Route("myclaims")]
    public IActionResult ClaimHistory()
    {
        return Ok("This is the claimstatus page of the CustomerCareController");
    }

}