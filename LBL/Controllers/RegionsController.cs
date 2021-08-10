﻿namespace LBL.Controllers
{
    using LBL.Data;
    using LBL.Data.Models;
    using LBL.Models.Regions;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    public class RegionsController : Controller
    {
        private readonly LBLDbContext data;

        public RegionsController(LBLDbContext data)
            => this.data = data;

        public IActionResult Add() => View(new AddRegionFormModel());

        [HttpPost]
        public IActionResult Add(AddRegionFormModel region)
        {

            if (ModelState.ErrorCount >0)
            {
                return View(region);
            }

            var regionData = new Region
            {
                FullName = region.FullName,
                ShortName = region.ShortName,
                Location = region.Location,
                LogoUrl = region.LogoURL,
                Organizer = region.Organizer
            };

            this.data.Regions.Add(regionData);
            this.data.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
