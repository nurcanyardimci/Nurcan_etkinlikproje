﻿using BusinessLayer.Concreate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Nurcan_etkinlik.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWritersRepository());

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
        public IActionResult Index(Writer p)
        {
			WriterValidator wv= new WriterValidator();
			ValidationResult results = wv.Validate(p);
			if (results.IsValid)
			{

                p.WriterStatus = true;
                p.WriterAbout = "denemetest";
                wm.WriterAdd(p);
                return RedirectToAction("Index", "Blog");
            }
			else
			{
				foreach(var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();

        }
    }
}
