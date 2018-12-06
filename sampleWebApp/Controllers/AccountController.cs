using Microsoft.AspNetCore.Mvc;

namespace sampleWebApp.Controllers
{
    public class AccountController
    {
        [Route("Account/{AccountId:int}")]
        public int ReturnAccountId(int AccountId)
        {
            return AccountId;
        }
        
        [Route("OnlyHasAction")]
        public string OnlyHasAction()
        {
            return "OnlyHasAction";
        }
    }
}