using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGLicitacoes.Models;
using SGLicitacoes.Repositorio;
using System;

namespace SGLicitacoes.Controllers
{
    public class BiddingController : Controller
    {
        private readonly IBiddingRepositorio _biddingRepositorio;
        public BiddingController(IBiddingRepositorio biddingRepositorio)
        {
            _biddingRepositorio = biddingRepositorio;
        }

        public IActionResult Index()
        {
          var licitacoes = _biddingRepositorio.SearchBidding();
            return View(licitacoes);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult DeleteModal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBidding(BiddingInfo licitacao)
        {
            licitacao.OpeningData = DateTime.Now;
            _biddingRepositorio.AddBidding(licitacao);
            return RedirectToAction("Index");
        }
    }
}
