﻿//using Microsoft.AspNetCore.Mvc;

//namespace Sandwich_King.Controllers
//{
//    public class FileUploadController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }

//        [HttpPost("FileUpload")]
//        public async Task<IActionResult> OnPostUploadAsync(List<IFormFile> files)
//        {
//            long size = files.Sum(f => f.Length);

//            foreach (var formFile in files)
//            {
//                if (formFile.Length > 0)
//                {
//                    var filePath = Path.Combine(_config["StoredFilesPath"],
//                        Path.GetRandomFileName());

//                    using (var stream = System.IO.File.Create(filePath))
//                    {
//                        await formFile.CopyToAsync(stream);
//                    }
//                }
//            }

//            // Process uploaded files
//            // Don't rely on or trust the FileName property without validation.

//            return Ok(new { count = files.Count, size });
//        }
//    }
//}
