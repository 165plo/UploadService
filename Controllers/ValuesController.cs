using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using UploadService.Attributes;
using Microsoft.AspNetCore.Http.Internal;

namespace UploadService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		// GET api/values
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "value1", "value2" };
		}
		
		[HttpPost]
		[RequestSizeLimit(2147483648)] // https://stackoverflow.com/questions/43305220/form-key-or-value-length-limit-2048-exceeded
		[DisableFormValueModelBinding] // https://dotnetcoretutorials.com/2017/03/12/uploading-files-asp-net-core/
		public void Upload()
		{
			Request.EnableRewind();
			Stream body = Request.Body;
			Debug.WriteLine(body.Length);
		}

	}
}
