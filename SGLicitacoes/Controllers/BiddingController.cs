using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGLicitacoes.Models;
using SGLicitacoes.Repositorio;
using System;
using System.Linq;

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

        public IActionResult Edit(int id)
        {
            BiddingInfo bidding = _biddingRepositorio.GetBiddingById(id);
            return View(bidding);
        }

        public IActionResult DeleteModal(int id)
        {
            BiddingInfo bidding = _biddingRepositorio.GetBiddingById(id);
            return View(bidding);
        }

        public IActionResult Delete(int id)
        {
            _biddingRepositorio.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(BiddingInfo licitacao)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    licitacao.OpeningData = DateTime.Now;
                    _biddingRepositorio.AddBidding(licitacao);
                    TempData["MensagemSucesso"] = "Licitação cadastrada com sucesso";
                    return RedirectToAction("Index");
                }
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar sua licitação , tente novamente , detalhe do erro: {erro}";

                throw;
            }


            return View(licitacao);

        }

        [HttpPost]
        public IActionResult Edit(BiddingInfo licitacao)
        {
            if (ModelState.IsValid)
            {
                _biddingRepositorio.UpdateBiddingById(licitacao);
                return RedirectToAction("Index");

            }
            return View(licitacao);
        }




    }
}
