using Data.EF;
using Logic.DTO;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILinkService linkService;
        public HomeController(ILinkService context)
        {
            linkService = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var listLinks = await linkService.GetAllLinks();

            return View(new ListLinksViewModel
            {
                Links = listLinks
            });
        }

        [HttpGet]
        public IActionResult CreateLink()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult<LinkDTO>> CreateLink(LinkViewModel linkViewModel)
        {
            if (ModelState.IsValid)
            {
                var link = new LinkDTO()
                {
                    Id = Guid.NewGuid(),
                    LongURl = linkViewModel.LongURl,
                    ShortURL = linkViewModel.LongURl,
                    Date = DateTime.Now,
                    VisitsNumber = 0
                };

                await linkService.CreateLink(link);

                return RedirectToAction("Index", "Home");
            } 
            else
            {
                return View(linkViewModel);
            }
        }


        [HttpGet]
        public async Task<ActionResult<LinkDTO>> EditLink(Guid id)
        {
            var link = await linkService.GetLinkById(id);

            if (link == null)
            {
                return NotFound();
            }

            return View(new LinkViewModel
            {
                Id = link.Id,
                LongURl =link.LongURl 
            });
        }


        public async Task<ActionResult<LinkDTO>> EditLink(Guid id, LinkViewModel linkViewModel)
        {

            if (ModelState.IsValid)
            {
                var link = new LinkDTO()
                {
                    Id = id,
                    LongURl = linkViewModel.LongURl
                };

                await linkService.UpdateLink(link);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(linkViewModel);
            }
        }


        public async Task<ActionResult> EditCounter(Guid id)
        {
            var link = await linkService.GetLinkById(id);

            if (link == null)
            {
                return NotFound();
            }

            await linkService.UpdateVisitsNumber(id);

            return Redirect(link.LongURl);
        }


        public async Task<IActionResult> DeleteLink(Guid id)
        {
            var link = await linkService.GetLinkById(id);

            if (link != null)
            {
                await linkService.DeleteLink(id);

                return RedirectToAction("Index", "Home");
            }

            return NotFound();
        }
    }
}